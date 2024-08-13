// See https://aka.ms/new-console-template for more information
using HtmlAgilityPack;
using MetaCriticCrawler;
using System.Net;
using System.Text;


// html = new HtmlWeb().Load("https://www.metacritic.com/game/solium-infernum/"); // lendo a página web

// Console.WriteLine(html.DocumentNode.InnerHtml); // baixando o html

// var titulo = html.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[1]/h1"); // pegando o xpath do h1 da página que estamos lendo (precisa ir em inspecionar, clicar com o lado direito e copiar o xpath full ), dessa forma ele pega o caminho do html

// uma dica é usar o LoadFromWebAsync pois ele faz de forma assincrona

// var htmlRequest = await new HtmlWeb().LoadFromWebAsync("https://www.metacritic.com/game/solium-infernum/"); // é melhor usar dessa forma por que tambem não usa o new Html, faz em uma linha só




Console.WriteLine("------------------------------------------------------------");



//////////////////////////////////////// segunda parte /////////////////////////////////////////


// como queremos pegar mais informações, vamos fazer com uma lista de links
var urls = new List<String> {
    "https://www.metacritic.com/game/solium-infernum/",
    "https://www.metacritic.com/game/sons-of-the-forest/"
};

// e uma lista de títulos para adicionar aqui os títulos
var titulos = new List<String>();

foreach (var url in urls)
{
    var html = await new HtmlWeb().LoadFromWebAsync(url);
    var titulo = html.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[1]/h1");
    titulos.Add(titulo.InnerText);
}

foreach (string titulo in titulos)
{
    Console.WriteLine(titulo);
}

Console.WriteLine("------------------------------------------------------------");


////////////////////////////////// terceira parte ////////////////////////////////////////////
// fazendo com uma quantidade muito alta de sites com uma novo tipo de forEach

// ele funciona dando uma leitura de um site para cada núcleo do processador do computador

Parallel.ForEach(urls, url =>
{
    var html = new HtmlWeb().LoadFromWebAsync(url).Result;

    var titulo = html.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[1]/h1");

    Console.WriteLine(titulo.InnerText);
});


Console.WriteLine("------------------------------------------------------------");

////////////////////////////// quarta parte /////////////////////////////////////////////

// fazendo um record para pegar as informações

// um novo objeto da classe MetacriticRecords

// aqui o novo array precisa ser do tipo MetacriticGame, então teremos que criar um novo

var titulosGames = new List<MetacriticGame>();

Parallel.ForEach(urls, url =>
{
    var html = new HtmlWeb().LoadFromWebAsync(url).Result;

    var titulo = html.DocumentNode.SelectSingleNode("/html/body/div[1]/div/div/div[2]/div[1]/div[1]/div/div/div[2]/div[3]/div[1]/h1");

    titulosGames.Add(new MetacriticGame(titulo.InnerText));


    // essa linha vai ajudar a melhorar a memória do nosos processador
    // ele limpa a memória do computador para limpar todo o site carregado da memória
    html = null;
    GC.Collect(); // limpar o garbact colect
});

titulosGames.ForEach(metacriticGame => Console.WriteLine(metacriticGame.nome));

Console.WriteLine("------------------------------------------------------------");







/////////////////////////////////////// quinta parte /////////////////////////////////

// salvar titulos em um csv

var csv = new StringBuilder();
csv.AppendLine("Título jogo");
titulosGames.ForEach(metacriticGame => csv.AppendLine(metacriticGame.nome));
File.WriteAllText("titulos.csv", contents: csv.ToString()); // fica salvo no bin do projeto
// See https://aka.ms/new-console-template for more information

using EstudoCrawler;
using EstudoCrawler.Utils;
using HtmlAgilityPack;
using System.Text;

var lojas = new List<LojaEntity>();
Utils utils = new Utils();

var html = new HtmlWeb().Load("https://shoppingcidadesp.com.br/lojas/#filters");
var nomeLojas = html.DocumentNode.SelectNodes("//div[@class='store-list']//div[@class='block']//h3"); // carrega as seções da página
var localLojas = html.DocumentNode.SelectNodes("//div[@class='store-list']//div[@class='block']//p[2]");
var numeroLojas = html.DocumentNode.SelectNodes("//div[@class='store-list']//div[@class='block']//a");

Parallel.For(0, nomeLojas.Count, i =>
{
    lojas.Add(new LojaEntity(
        nomeLojas.ElementAt(i).InnerText,
        utils.FormatarValor(localLojas.ElementAt(i).InnerText, "-"),
        numeroLojas.ElementAtOrDefault(i)?.InnerText.Trim()

    ));
    GC.Collect();
});


lojas.ForEach(x => {
    Console.WriteLine($"{x}\n");
});

// salvar em um arquivo csv

var csv = new StringBuilder();
csv.AppendLine("Nome da loja,Telefone da loja,Local da loja");
lojas.ForEach(loja => csv.AppendLine($"{loja.nomeLoja},{loja.telefoneLoja},{loja.localLoja}"));
File.WriteAllText("lojas.csv", contents: csv.ToString());






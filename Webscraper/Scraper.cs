using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HtmlAgilityPack;

namespace Webscraper
{
    public class Scraper
    {
        //NB - Add system.web reference to project

        private ObservableCollection<EntryModel> _entries = new ObservableCollection<EntryModel>();

        public ObservableCollection<EntryModel> Entries
        {
            get { return _entries; }
            set { _entries = value; }
        }

        public void ScrapeData(string page)
        {
            var web = new HtmlWeb();
            var doc = web.Load(page);

            var Articles = doc.DocumentNode.SelectNodes("//*[@class = 'article-single']");  //Filter the webpage page looking for all article-single in the html code

            foreach (var article in Articles)
            {
                var header = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class = 'article-header']").InnerText);
                var description = HttpUtility.HtmlDecode(article.SelectSingleNode(".//li[@class = 'article-copy']").InnerText);

                _entries.Add(new EntryModel { Title = header, Description = description });
            }
        }

        public void Export()
        {
            //using(TextWriter tw = File.CreateText("sampleData.csv"))
            //{
            //    using (var cw = new CsvWriter(tw))
            //    {
            //        foreach (var entry in Entries)
            //        {
            //            cw.WriteRecord(entry);
            //            cw.NextRecord();
            //        }
            //    }
            //}
        }

    }
}

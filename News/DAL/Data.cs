using Models;
using System;
using System.Collections.Generic;
using System.Web.Configuration;
using System.Xml;
using System.ServiceModel;
using System.ServiceModel.Syndication;

namespace DAL
{
    public class Data
    {
        string url = WebConfigurationManager.AppSettings["SourcePath"];
        public NewsModel GetNews()
        {
            NewsModel news = null;

            try
            {
                XmlReader reader = XmlReader.Create(url);
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                news = new NewsModel()
                {
                    title = feed.Title.Text,
                    updated = feed.LastUpdatedTime.UtcDateTime,
                    articles = new List<Article>()
                };


                foreach (SyndicationItem item in feed.Items)
                {
                    news.articles.Add(new Article
                    {
                        title = item.Title.Text,
                        date = item.PublishDate.UtcDateTime,
                        content = ((TextSyndicationContent)item.Content).Text,
                        linkToContent = item.Links.Count > 0 ? item.Links[0].Uri.ToString():string.Empty
                    });
                                   
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return news;

        }



    }
}

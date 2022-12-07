using DAL;
using Models;


namespace BL
{
    public class NewsHandler
    {
        public NewsModel GetNews()
        {
            return new Data().GetNews(); ;
        }
    }
}

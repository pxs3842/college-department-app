using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project3___IST_App
{
    public class DataService
    {

        /// <summary>
        /// Gets data from the IST API.
        /// </summary>
        /// <param name="url">The url to the IST API</param>
        /// <returns>Returns the requested API information as a string</returns>
        private string GetRestData(string url)
        {
            // connect to the API
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(AppConstant.ApiUrl + url);
            try
            {
                WebResponse response = request.GetResponse();

                using (Stream responseStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);
                    return reader.ReadToEnd();
                }
            }
            catch (WebException we)
            {
                // Something goes wrong, get the error response, then do something with it
                WebResponse err = we.Response;
                using (Stream responseStream = err.GetResponseStream())
                {
                    StreamReader r = new StreamReader(responseStream, Encoding.UTF8);
                    string errorText = r.ReadToEnd();
                    // display or log error
                    Console.WriteLine(errorText);
                }
                throw;
            }
        } // end getRestData

        public About GetAboutInformation()
        {
            // get About information
            string jsonAbout = GetRestData(AppConstant.AboutPage);

            // need a way to get the JSON form into an About object
            About about = JToken.Parse(jsonAbout).ToObject<About>();

            return about;
        }

        public Degrees GetDegreeInformation()
        {
            // get Degree information
            string jsonDegree = GetRestData(AppConstant.DegreesPage);

            Degrees degree = JToken.Parse(jsonDegree).ToObject<Degrees>();

            return degree;
        }

        public Minors GetMinorsInformation()
        {
            // get Minors information
            string jsonMinors = GetRestData(AppConstant.MinorsPage);

            Minors minor = JToken.Parse(jsonMinors).ToObject<Minors>();

            return minor;
        }

        public People GetPeopleInformation()
        {
            // get People information
            string jsonPeople = GetRestData(AppConstant.PeoplePage);

            People people = JToken.Parse(jsonPeople).ToObject<People>();

            return people;
        }

        public Employment GetEmploymentInformation()
        {
            // get Employment information
            string jsonEmployment = GetRestData(AppConstant.EmploymentPage);

            Employment employment = JToken.Parse(jsonEmployment).ToObject<Employment>();

            return employment;
        }

        public News GetNewsInformation()
        {
            // get News information
            string jsonNews = GetRestData(AppConstant.NewsPage);

            News news = JToken.Parse(jsonNews).ToObject<News>();

            return news;
        }

        public Research GetResearchInformation()
        {
            // get research information
            string jsonResearch = GetRestData(AppConstant.ResearchPage);

            Research research = JToken.Parse(jsonResearch).ToObject<Research>();

            return research;
        }

        public Footer GetFooterInformation()
        {
            // get footer information
            string jsonFooter = GetRestData(AppConstant.FooterPage);

            Footer footer = JToken.Parse(jsonFooter).ToObject<Footer>();

            return footer;
        }

        public Resources getResourcesInformation()
        {
            // get resources information
            string jsonResources = GetRestData(AppConstant.ResourcesPage);

            Resources resources = JToken.Parse(jsonResources).ToObject<Resources>();

            return resources;
        }
    }
}

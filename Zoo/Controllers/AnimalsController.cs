using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zoo.ViewModels;

namespace Zoo.Controllers
{
    public class AnimalsController : ApiController
    {
        public static List<AnimalViewModel> ImLazyViewModels = new List<AnimalViewModel>(){
            new AnimalViewModel(){
                ID = 1,
                 DateOfBirth = DateTime.Now.AddMonths(-23),
                  Name="Mooey",
                  AnimalType="Cow",
                  Image="/Content/cow.jpg"
            },
            new AnimalViewModel(){
                ID = 2,
                 DateOfBirth = DateTime.Now.AddDays(-23),
                  Name="Snickers",
                  AnimalType="Puppy",
                  Image="/Content/puppy.jpg"
            },
            new AnimalViewModel(){
                ID = 3,
                 DateOfBirth = DateTime.Now.AddDays(-333),
                  AnimalType="T-Rex",
                  Name="Mr. T",
                  Image="/Content/trex.jpg"
            }
        };
        // GET api/<controller>
        public IEnumerable<AnimalViewModel> Get()
        {
            return ImLazyViewModels;
        }

        // GET api/<controller>/5
        public AnimalViewModel Get(int id)
        {
            return ImLazyViewModels.FirstOrDefault(a => a.ID == id);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]AnimalViewModel value)
        {
            //implement
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            // implement
        }
    }
}
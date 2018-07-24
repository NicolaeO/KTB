using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KTB.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;


using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
// using System.Threading.Tasks;


namespace KTB.Controllers{
    public class GameController : Controller{


        private KTBContext _context;
        public static string URL = "https://opentdb.com/api.php?amount=10";
        public GameController(KTBContext context){
            _context = context;
        }

        public IActionResult Main(){
            GetRequest(URL);

            return RedirectToAction("Index", "Home");
        }


        async static void GetRequest(string url){
            using(HttpClient client = new HttpClient()){
                using (HttpResponseMessage response = await client.GetAsync(url)){
                    using(HttpContent content = response.Content){
                        string mycontent = await content.ReadAsStringAsync();
                        Console.WriteLine("****************************************************");
                        Console.WriteLine(mycontent);
                        Console.WriteLine("****************************************************");
                        // content.ReadAsAsync
                    }
                }
            }
        }




/*
        static HttpClient client = new HttpClient();

        static async Task RunAsync(){
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://opentdb.com/api.php?");
            client.DefaultRequestHeaders.Accept.Clear();
            // client.DefaultRequestHeaders.Accept.Add(
                // new MediaTypeWithQualityHeaderValue("application/json"));
        }

        
        static async Task<TriviaData> GetProductAsynk(string path){
            List<TriviaData> data = new List<TriviaData>();
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode){
                data = await response.Content.ReadAsAsync<TriviaData>();
            } 
            return data;

        }

 */

    }
}
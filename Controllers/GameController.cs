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
using System.Threading.Tasks;


namespace KTB.Controllers{
    public class GameController : Controller{


        static HttpClient client = new HttpClient();

        static async Task RunAsync(){
            // Update port # in the following line.
            client.BaseAddress = new Uri("https://opentdb.com/api.php?");
            client.DefaultRequestHeaders.Accept.Clear();
            // client.DefaultRequestHeaders.Accept.Add(
                // new MediaTypeWithQualityHeaderValue("application/json"));
        }

        private KTBContext _context;
        public GameController(KTBContext context){
            _context = context;
        }

        public IActionResult NewGame(){

        }

        static async Task<TriviaData> GetProductAsynk(string path){
            List<TriviaData> data = new List<TriviaData>();
            HttpResponsemessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode){
                data = await response.Content.ReadAsAsynk<TriviaData>();
            } 
            return data;

        }
    }
}
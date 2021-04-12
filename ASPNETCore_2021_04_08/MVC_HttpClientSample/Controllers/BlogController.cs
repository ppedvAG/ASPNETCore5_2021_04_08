using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain_Sample.Entities;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace MVC_HttpClientSample.Controllers
{
    public class BlogController : Controller
    {
        private string baseUrl = "https://localhost:44386/api/Blog/";

        public BlogController()
        {
            
        }

        // GET: Blog
        public async Task<IActionResult> Index()
        {

            HttpClient client = new HttpClient();
            HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Get, baseUrl);
            HttpResponseMessage response = await client.SendAsync(requestMessage);

            string jsonText = await response.Content.ReadAsStringAsync();

            List<Blog> blogList = JsonConvert.DeserializeObject<List<Blog>>(jsonText);


            return View(blogList);
        }

        // GET: Blog/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string url = baseUrl + id.Value.ToString(); //https://localhost:44386/api/Blog/123
            Blog currentBlog = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();
                currentBlog = JsonConvert.DeserializeObject<Blog>(jsonText);
            }

            if (currentBlog == null)
            {
                return NotFound();
            }

            return View(currentBlog);
        }

        // GET: Blog/Create
        public IActionResult Create() 
        {
            return View();
        }

        // POST: Blog/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Content,CreateAt")] Blog blog)
        {
            if (ModelState.IsValid)
            {
                string json = JsonConvert.SerializeObject(blog);

                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.PostAsync(baseUrl, data);


                    //200er Code sollte zurückgebeben werden.
                    string result = await response.Content.ReadAsStringAsync();
                }
                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blog/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            string url = baseUrl + id.Value.ToString(); //https://localhost:44386/api/Blog/123
            Blog currentBlog = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();
                currentBlog = JsonConvert.DeserializeObject<Blog>(jsonText);
            }


            if (currentBlog == null)
            {
                return NotFound();
            }
            return View(currentBlog);
        }

        // POST: Blog/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Content,CreateAt")] Blog blog)
        {
            if (id != blog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                string url = baseUrl + id.ToString();

                string json = JsonConvert.SerializeObject(blog);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                using (HttpClient client = new HttpClient())
                {
                    var response = client.PutAsync(url, data);
                    string result = await response.Result.Content.ReadAsStringAsync();
                }

                return RedirectToAction(nameof(Index));
            }
            return View(blog);
        }

        // GET: Blog/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            string url = baseUrl + id.Value.ToString(); //https://localhost:44386/api/Blog/123
            Blog currentBlog = null;
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                string jsonText = await response.Content.ReadAsStringAsync();
                currentBlog = JsonConvert.DeserializeObject<Blog>(jsonText);
            }


            if (currentBlog == null)
            {
                return NotFound();
            }

            return View(currentBlog);
        }

        // POST: Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            string url = baseUrl + id.ToString();

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.DeleteAsync(url);
                string result = await response.Content.ReadAsStringAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        
    }
}

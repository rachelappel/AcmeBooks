﻿using AcmeBooks.Models;
using AcmeBooksAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AcmeBooksAPI.Services
{
    public class StaffPick
    { 
 
        public string QuickPicks(string[] ISBNs)
        {
            // move this to the controller
            return "";
        }
       
        
        private readonly HttpClient _httpClient;
        private readonly string _staffPicksUrl;

        public StaffPick()
        {
            _httpClient = new HttpClient();
            /*_httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));*/
            _staffPicksUrl = "https://localhost:7090/api/books/staffpicks"; 
        }

        public async Task WeeklyPicks()
        {
            try
            {
                var response = await _httpClient.GetAsync(_staffPicksUrl);
                response.EnsureSuccessStatusCode();

                var books = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Staff Picks:");
                Console.WriteLine(books);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching staff picks: {ex.Message}");
            }
        }
    }

    // init only setters (editor's picks)
    // params collection
    // pattern matching (match by genre)
}
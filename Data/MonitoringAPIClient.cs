using PetShopMetrics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PetShopMetrics
{
    public class MonitoringAPIClient
    {
        public HttpClient _httpClient;

        public MonitoringAPIClient(HttpClient client)
        {
            _httpClient = client;
        }

        ///////////////////////////////////////////////////// MerchandiseFilter /////////////////////////////////////////

        public async Task<IEnumerable<string>> GetDistinctCategories()
        {
            var response = await _httpClient.GetAsync("MerchandiseFilter/Categories");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<string>>();
        }

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseFilter()
        {
            var response = await _httpClient.GetAsync("MerchandiseFilter");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
        }

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseByCategory(string category)
        {
            var response = await _httpClient.GetAsync($"MerchandiseFilter/ByCategory/{category}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
        }

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseByMonth(int month)
        {
            var response = await _httpClient.GetAsync($"MerchandiseFilter/ByMonth/{month}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
        }

        public async Task<int> GetMerchandiseSearchCountByMonthAndCategory(int month, string category)
        {
            var response = await _httpClient.GetAsync($"MerchandiseFilter/ByMonth/{month}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
            IEnumerable<MerchandiseFilter> list = responseContent.ToList().Where(x => x.Category == category);

            return list.Count();
        }

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseByValueAndTimeSpan(string category, DateTime start, DateTime end)
        {
            var response = await _httpClient.GetAsync($"MerchandiseFilter/ByCategory/{category}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();

            return responseContent.ToList().Where(x => x.DateAndTime.Date >= start.Date && x.DateAndTime.Date <= end);
        }

        /////////////////////////////////////////////////////////// Session //////////////////////////////////////////////

        public async Task<IEnumerable<Session>> GetSessions()
        {
            var response = await _httpClient.GetAsync("Session");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<Session>>();
        }

        ////////////////////////////////////////////////////////// PetFilter /////////////////////////////////////////////

        public async Task<IEnumerable<string>> GetDistinctPetFilterValues()
        {
            var response = await _httpClient.GetAsync("PetFilter/DistinctValues");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<string>>();
        }

        public async Task<IEnumerable<string>> GetDistinctPetFilterCriteria()
        {
            var response = await _httpClient.GetAsync("PetFilter/DistinctFilterCriteria");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<string>>();
        }

        public async Task<IEnumerable<string>> GetDistinctPetFilterBreed()
        {
            var response = await _httpClient.GetAsync("PetFilter/DistinctBreed");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<string>>();
        }


        public async Task<IEnumerable<PetFilter>> GetPetFilter()
        {
            var response = await _httpClient.GetAsync("PetFilter");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
        }

        public async Task<IEnumerable<PetFilter>> GetPetFilterByValue(string value)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByValue/{value}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
        }

        public async Task<IEnumerable<PetFilter>> GetPetFilterByFilterCriteria(string criteria)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByCriteria/{criteria}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
        }

        public async Task<IEnumerable<PetFilter>> GetPetFilterByMonth(int month)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByMonth/{month}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
        }

        public async Task<int> GetPetFilterSearchCountByMonthAndCriteria(int month, string criteria)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByMonth/{month}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
            IEnumerable<PetFilter> list = responseContent.ToList().Where(x => x.FilterCriteria == criteria);

            return list.Count();
        }

        public async Task<int> GetPetFilterSearchCountByMonthAndValue(int month, string value)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByMonth/{month}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();
            IEnumerable<PetFilter> list = responseContent.ToList().Where(x => x.Value == value);

            return list.Count();
        }

        public async Task<IEnumerable<PetFilter>> GetPetFilterByCriteriaAndTimeSpan(string criteria, DateTime start, DateTime end)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByCriteria/{criteria}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();

            return responseContent.ToList().Where(x => x.DateAndTime.Date >= start.Date && x.DateAndTime.Date <= end.Date);
        }

        public async Task<IEnumerable<PetFilter>> GetPetFilterByValueAndTimeSpan(string value, DateTime start, DateTime end)
        {
            var response = await _httpClient.GetAsync($"PetFilter/ByValue/{value}");
            response.EnsureSuccessStatusCode();

            var responseContent = await response.Content.ReadAsAsync<IEnumerable<PetFilter>>();

            return responseContent.ToList().Where(x => x.DateAndTime.Date >= start.Date && x.DateAndTime.Date <= end.Date);
        }


    }
}

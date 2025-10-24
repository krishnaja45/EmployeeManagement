using System.Net.Http;
using System.Net.Http.Json;
using EmployeeShared;

namespace EmployeeApp.Services
{
    public class EmployeeService
    {
        private readonly HttpClient _http;
        public EmployeeService(HttpClient http) => _http = http;

        public async Task<List<Employee>> GetAllAsync() =>
            await _http.GetFromJsonAsync<List<Employee>>("api/employees") ?? new List<Employee>();

        public async Task<Employee?> GetByIdAsync(int id) =>
            await _http.GetFromJsonAsync<Employee>($"api/employees/{id}");

        public async Task<HttpResponseMessage> CreateAsync(Employee e) =>
            await _http.PostAsJsonAsync("api/employees", e);

        public async Task<HttpResponseMessage> UpdateAsync(Employee e) =>
            await _http.PutAsJsonAsync($"api/employees/{e.Id}", e);

        public async Task<HttpResponseMessage> DeleteAsync(int id) =>
            await _http.DeleteAsync($"api/employees/{id}");
    }
}

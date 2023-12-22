using HMS_P8.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace HMS_P8.Controllers
{
    public class PraticienController : Controller
    {
        public async Task<IActionResult> ListePraticiens()
        {
            // Code pour récupérer la liste des praticiens depuis l'API Gateway
            // Utilisez HTTPClient ou d'autres méthodes appropriées pour appeler votre API.

            // Exemple de code :
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://localhost:7289/ApiGateway/Praticien");

                if (response.IsSuccessStatusCode)
                {
                    // Assurez-vous d'utiliser les bibliothèques appropriées pour la désérialisation
                    // Dans cet exemple, j'utilise System.Text.Json
                    var content = await response.Content.ReadAsStringAsync();
                    var praticiens = System.Text.Json.JsonSerializer.Deserialize<List<Praticien>>(content);

                    // Remarque : Assurez-vous d'inclure la vue correspondante dans le dossier Views/Praticien
                    return View();
                }
                else
                {
                    // Gérez les erreurs de requête ici
                    return View("Error");
                }
            }
        }

    }

    }

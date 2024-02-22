using Microsoft.AspNetCore.Mvc;

namespace isGuvenligi.Controllers
{
    public class ParametreController : Controller
    {
      
            [Route("Parametre/Cikti/{id}/{ad}")]
            public string Cikti(int id, string ad)
            {
                return $"Parametreden gelen id={id}, ad={ad}";
            }
       
    }
}

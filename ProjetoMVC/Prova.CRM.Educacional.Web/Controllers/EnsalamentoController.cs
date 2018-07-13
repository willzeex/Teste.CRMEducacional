namespace Prova.CRM.Educacional.Web.Controllers
{
    using AutoMapper;
    using Domain.Entities;
    using Domain.Interfaces.Services;
    using Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class EnsalamentoController : Controller
    {
        private readonly string fileName = "arquivo-1.csv";
        private readonly IEnsalamentoService _ensalamentoService;

        public EnsalamentoController(IEnsalamentoService ensalamentoService)
        {
            _ensalamentoService = ensalamentoService;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> ImportarArquivo()
        {
            try
            {
                foreach (string file in Request.Files)
                {
                    var fileContent = Request.Files[file];
                    if (fileContent != null && fileContent.ContentLength > 0)
                    {
                        var stream = fileContent.InputStream;
                        var path = Path.Combine(Server.MapPath("~/Content/Uploads"), fileName);
                        using (var fileStream = System.IO.File.Create(path))
                        {
                            stream.CopyTo(fileStream);
                        }
                    }
                }
            }
            catch (Exception)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Upload failed");
            }

            return Json("File uploaded successfully");
        }

        [HttpPost]
        public ActionResult ProcessarEnsalamento()
        {
            try
            {
                string path = Server.MapPath("~/Content/Uploads/" + fileName);
                List<Sala> salas = _ensalamentoService.DistribuirCandidatos(path);
                return PartialView("_ListaSalas", Mapper.Map<List<Sala>, List<SalaViewModel>>(salas));
            }
            catch (Exception ex)
            {
                Response.StatusCode = (int)HttpStatusCode.BadRequest;
                return Json("Falha ao processar ensalamento.");
            }
        }
    }
}
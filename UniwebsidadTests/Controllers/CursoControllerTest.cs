using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniwebsidad.BaseDatos;
using Uniwebsidad.Controllers;
using Uniwebsidad.Models;
using Uniwebsidad.Repository;
using Uniwebsidad.Service;

namespace UniwebsidadTests.Controllers
{
    [TestFixture]
    class CursoControllerTest
    {

        [Test]
        public void MuestraLista()
        {
            var service = new Mock<IUsuarioService>();
            service.Setup(o => o.GetLoggedUser()).Returns("admin");

            var repository = new Mock<ICursoRepository>();
            repository.Setup(o => o.ObtenerTodosLosCursos()).Returns(new List<Curso>());

            var controller = new CursoController(repository.Object, service.Object);
            var view = controller.Index() as ViewResult;

            Assert.AreEqual("Index", view.ViewName);

        }

    }
}

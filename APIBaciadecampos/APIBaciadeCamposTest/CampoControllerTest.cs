using APIBaciadecampos;
using APIBaciadecampos.Models;
using APIBaciadecampos.Services;
using APIComprasTest;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace APIBaciadeCamposTest
{
    public class CampoControllerTest
    {
        CampoController _controller;
        ICampoService _service;
        public CampoControllerTest()
        {
            _service = new CampoServiceFake();
            _controller = new CampoController(_service);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.Get();
            // Assert
            Assert.IsType<OkObjectResult>(okResult.Result);
        }
        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.Get().Result as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Campo>>(okResult.Value);
            Assert.Equal(5, items.Count);
        }
    }
}

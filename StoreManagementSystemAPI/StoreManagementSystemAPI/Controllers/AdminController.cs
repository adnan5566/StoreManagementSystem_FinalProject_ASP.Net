﻿using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace StoreManagementSystemAPI.Controllers
{
    public class AdminController : ApiController
    {
        [HttpPost]
        [Route("API/AddUserrr")]
        public HttpResponseMessage AddUser(UserDTO C)
        {
            try
            {
                var data = UserService.AddUser(C);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Data" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("API/ViewAllUserr")]
        public HttpResponseMessage ViewUser()
        {
            try
            {
                var data = UserService.ViewUser();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("API/ViewAllUserr/{Id}")]
        public HttpResponseMessage ViewUser(int id)
        {
            try
            {
                var data = UserService.ViewUser(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        //Product Related 
        [HttpGet]
        [Route("API/User/deletee/{id}")]
        public HttpResponseMessage DeleteUser(int id)
        {
            var res = UserService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, res);

        }
        [HttpPost]
        [Route("API/AddProductt")]
        public HttpResponseMessage AddProduct(ProductDTO C)
        {
            try
            {
                var data = ProductService.AddProduct(C);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.BadRequest, new { Message = "Invalid Data" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("API/ViewProductt/{Id}")]
        public HttpResponseMessage ViewProduct(int id)
        {
            try
            {
                var data = SearchService.ViewProduct(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

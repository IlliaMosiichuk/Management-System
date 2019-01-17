using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ViewModels;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Repositories;
using ApplicationCore.Interfaces.Services;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize]
    [ApiController]
    public class OrdersController : BaseApiController
    {
        private readonly IOrderService _orderService;
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService, IOrderRepository orderRepository, 
            IUnitOfWork unitOfWork, IMapper mapper)
        {
            _orderService = orderService;
            _orderRepository = orderRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var orders = _orderRepository.FindAll();
            var model = new OrderListViewModel();
            _mapper.Map(orders, model.Orders);
            return Ok(model);
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var order = _orderRepository.Find(id);
            if (order != null)
            {
                var model = new OrderListItemViewModel();
                _mapper.Map(order, model);
                model.Id = id;
                return Ok(model);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Import()
        {
            var file = Request.Form.Files[0];
            if (file != null && file.Length != 0)
            {
                var orders = _orderService.GetImportedOrders(file.OpenReadStream());
                _orderService.ProcessImportedOrders(orders);
                _unitOfWork.Commit();
                return Ok();
            }

            return BadRequest(); 
        }

        [HttpPost]
        public IActionResult Post([FromBody]OrderListItemViewModel model)
        {
            if (ModelState.IsValid)
            {
                var order = _orderRepository.Find(model.Id);
                order.TrackingNumber = model.TrackingNumber;
                order.Reference = model.Reference;
                order.Processed = model.Processed;
                _orderRepository.Update(order);
                _unitOfWork.Commit();
                return Ok();
            }

            return BadRequest();
        }
    }
}
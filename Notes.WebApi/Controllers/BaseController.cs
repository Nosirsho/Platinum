﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using MediatR;

namespace Notes.WebApi.Controllers {
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class BaseController : ControllerBase {
		private IMediator _mediator;
		protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
		internal Guid UserId => !User.Identity.IsAuthenticated
			? Guid.Empty
			: Guid.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value);
	}
}

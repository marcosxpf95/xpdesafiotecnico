using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using XPDesafioTecnico.DTOs;
using XPDesafioTecnico.Models.Models;
using XPDesafioTecnico.Services.Interfaces;

namespace XPDesafioTecnico.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;
        private readonly IMapper _mapper;
        private readonly IClienteService _clienteService;

        public ClientesController(
            ILogger<ClientesController> logger,
            IMapper mapper,
            IClienteService clienteService)
        {
            _logger = logger;
            _mapper = mapper;
            _clienteService = clienteService;
        }

        [HttpGet]
        public async Task<IActionResult> GetClientes()
        {
            var clientes = await _clienteService.GetClientes();
            var clientesDto = _mapper.Map<IReadOnlyCollection<ClienteGetDto>>(clientes);

            return Ok(clientesDto);
        }

        [HttpGet("detalhe")]
        public async Task<IActionResult> GetClientesDetalhado()
        {
            var clientesDetalhado = await _clienteService.GetClientesDetalhado();
            var clientesDetalhadoDto = _mapper.Map<List<ClienteDetalhadoGetDto>>(clientesDetalhado);

            return Ok(clientesDetalhadoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ClienteCreationDto clienteDto)
        {
            if (clienteDto == null)
            {
                return BadRequest("Dados inválidos");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var cliente = _mapper.Map<Cliente>(clienteDto);

                await _clienteService.CreateCliente(cliente);
                
                var clientesDto = _mapper.Map<ClienteGetDto>(cliente);
                return CreatedAtAction("GetClientes", new { id = cliente.ID }, clientesDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao criar o cliente");
                return StatusCode(500, "Erro interno do servidor");
            }
        }

    }
}

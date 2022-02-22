﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using OdlukaODavanjuUZakup.Data;
using OdlukaODavanjuUZakup.Entities;
using OdlukaODavanjuUZakup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdlukaODavanjuUZakup.Controllers
{
    /// <summary>
    /// Controller za entitet odluka o davanju u zakup
    /// </summary>
    [ApiController]
    [Route("api/Odluke")]
    [Produces("application/json", "application/xml")]
    public class OdlukaoDavanjuuZakupController : ControllerBase
    {

        private readonly LinkGenerator linkGenerator;
        private readonly IMapper mapper;
        private readonly IOdlukaoDavanjuuZakupRepository odlukaoDavanjuuZakupRepository;
        /// <summary>
        /// 
        /// Konstruktor
        /// </summary>
        /// <param name="odlukaoDavanjuuZakupRepository"></param>
        /// <param name="linkGenerator"></param>
        /// <param name="mapper"></param>
        public OdlukaoDavanjuuZakupController(IOdlukaoDavanjuuZakupRepository odlukaoDavanjuuZakupRepository, LinkGenerator linkGenerator, IMapper mapper)

        {
            this.linkGenerator = linkGenerator;
            this.mapper = mapper;
            this.odlukaoDavanjuuZakupRepository = odlukaoDavanjuuZakupRepository;
        }
        /// <summary>
        /// Vraca listu svih odluka o davanju u zakup
        /// </summary>
        /// <returns></returns>
        /// <response code="200">Uspesno vraca sve odluke</response>
        /// <response code="404">Nema odluka u bazi</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpHead]
        public ActionResult<List<OdlukaoDavanjuuZakupDto>> GetOdluke()
        {
            var odluke = odlukaoDavanjuuZakupRepository.GetOdluke();
            if (odluke == null || odluke.Count == 0)
            {
                return NoContent();
            }
            return Ok(mapper.Map<List<OdlukaoDavanjuuZakupDto>>(odluke));
        }
        /// <summary>
        /// Vraca Odluku sa prosledjenim ID
        /// </summary>
        /// <param name="odlukaoDavanjuuZakupID">ID odluke koju trazimo</param>
        /// <returns></returns>
        /// <response code="200">Uspesno vraca pronadjenu odluku</response>
        /// <response code="404">Ne postoji takva odluka u bazi</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{OdlukaoDavanjuuZakupID}")]
        public ActionResult<OdlukaoDavanjuuZakupDto> GetOdluka (Guid odlukaoDavanjuuZakupID)
        {
            var odluka = odlukaoDavanjuuZakupRepository.GetOdlukaById(odlukaoDavanjuuZakupID);
            if (odluka == null)
            {
                return NotFound();
            }
            return Ok(mapper.Map<OdlukaoDavanjuuZakupDto>(odluka));
         }
        /// <summary>
        /// Kreira se nova odluka o davanju u zakup u bazi
        /// </summary>
        /// <param name="odlukaoDavanjuuZakup">Prosledjen body odluke</param>
        /// <returns></returns>
        /// <response code="201">Uspesno je kreirana</response>
        /// <response code="500">Doslo je do greske prilikom kreiranja</response>
        [HttpPost]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<OdlukaoDavanjuuZakupDto> CreateOdluka([FromBody] OdlukaoDavanjuuZakupCreationDto odlukaoDavanjuuZakup)
        {
            try
            {
                var odlukaoDavanjuuZakupEntity = mapper.Map<OdlukaoDavanjuuZakup>(odlukaoDavanjuuZakup);
                var confirmation = odlukaoDavanjuuZakupRepository.CreateOdluka(odlukaoDavanjuuZakupEntity);
                odlukaoDavanjuuZakupRepository.SaveChanges();
                string location = linkGenerator.GetPathByAction("GetOdluke", "OdlukaoDavanjuuZakup", new { odlukaoDavanjuuZakupID = confirmation.OdlukaoDavanjuuZakupID });
                return Created(location, mapper.Map<OdlukaoDavanjuuZakupConfirmationDto>(confirmation));

            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Create error");
            }
        }
        /// <summary>
        /// Brisanje odluke sa odredjenim ID iz baze
        /// </summary>
        /// <param name="odlukaoDavanjuuZakupID"></param>
        /// <returns></returns>
        /// <response code="200">Vraca izbrisanu odluku</response>
        /// <response code="404">Odluka nije pronadjena</response>
        /// <response code="500">Doslo je do greske na serveru prilikom brisanja odluke</response>
        /// <response code ="204" >Nakon uspesnog brisanja odluke</response>
        [HttpDelete("{OdlukaoDavanjuuZakupID}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public IActionResult DeleteOdluka(Guid odlukaoDavanjuuZakupID)
        {
            try
            {
                var odluka = odlukaoDavanjuuZakupRepository.GetOdlukaById(odlukaoDavanjuuZakupID);
                if (odluka == null)
                {
                    return NotFound();
                }
                odlukaoDavanjuuZakupRepository.DeleteOdluka(odlukaoDavanjuuZakupID);
                odlukaoDavanjuuZakupRepository.SaveChanges();
                return NoContent();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Delete error");
            }
        }
        /// <summary>
        /// Azuriranje 
        /// </summary>
        /// <param name="odluka"></param>
        /// <returns></returns>
        [HttpPut]
        [Consumes("application/json")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<OdlukaoDavanjuuZakupConfirmationDto> UpdateOdlukaoDavanjuuZakup(OdlukaoDavanjuuZakupUpdateDto odluka)
        {
            try
            {
                //Proveriti da li uopšte postoji prijava koju pokušavamo da ažuriramo.
                if (odlukaoDavanjuuZakupRepository.GetOdlukaById(odluka.OdlukaoDavanjuuZakupID) == null)
                {
                    return NotFound(); //Ukoliko ne postoji vratiti status 404 (NotFound).
                }
                OdlukaoDavanjuuZakup odluka2 = mapper.Map<OdlukaoDavanjuuZakup>(odluka);
                OdlukaoDavanjuuZakupConfirmation confirmation = odlukaoDavanjuuZakupRepository.UpdateOdluka(odluka2);
                return Ok(mapper.Map<OdlukaoDavanjuuZakupDto>(confirmation));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Update error");
            }
        }
        [HttpOptions]
        public IActionResult GetOdlukaODavanjuUZakupOptions()
        {
            Response.Headers.Add("Allow", "GET, POST, PUT, DELETE");
            return Ok();
        }
    }
}

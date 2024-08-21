using CountryAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CountryAPI.Controllers
{
    public class CountryController : ApiController
    {
        private List<Country> _countries = new List<Country>();

        public CountryController()
        {
           
            _countries.Add(new Country { id = 1, CountryName = "India", Captial = "NewDelhi" });
            _countries.Add(new Country { id = 2, CountryName = "Canada", Captial = "Ottawa" });
            _countries.Add(new Country { id = 3, CountryName = "United States", Captial = "Washington D.C." });
        }

        // GET api/country
        public IHttpActionResult GetAllCountries()
        {
            return Ok(_countries);
        }

        // GET api/country/1
        public IHttpActionResult GetCountry(int id)
        {
            var country = _countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            return Ok(country);
        }

        // POST api/country
        public IHttpActionResult CreateCountry(Country country)
        {
            _countries.Add(country);
            return CreatedAtRoute("DefaultApi", new { id = country.id }, country);
        }

        // PUT api/country/2
        public IHttpActionResult UpdateCountry(int id, [FromBody] Country country)
        {
            if (country == null || country.id != id)
            {
                return BadRequest();
            }

            var existCountry = _countries.FirstOrDefault(c => c.id == id);
            if (existCountry == null)
            {
                return NotFound();
            }

            existCountry.CountryName = country.CountryName;
            existCountry.Captial = country.Captial;

            return Ok(existCountry);
        }

        // DELETE api/country/2
        public IHttpActionResult DeleteCountry(int id)
        {
            var country = _countries.FirstOrDefault(c => c.id == id);
            if (country == null)
            {
                return NotFound();
            }
            _countries.Remove(country);
            return Ok();
        }
    }
}
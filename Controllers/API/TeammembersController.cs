using AutoMapper;
using codefirstapp.Data;
using codefirstapp.Dtos;
using codefirstapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace codefirstapp.Controllers.API
{
    public class TeammembersController : ApiController
    {
        private PlayerContext _playerctx;
            public TeammembersController()
        {
            _playerctx = new PlayerContext();
        }
        //GET /api/players
        public IEnumerable<PlayersDto> GetTeammembers()
        {
            return _playerctx.Players.ToList().Select(Mapper.Map < Players, PlayersDto>);

        }
        //GET /api/players/1
        public Players GetPlayer(int id)
        {
            var player = _playerctx.Players.SingleOrDefault(p => p.PlayersID == id);
            if(player == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return player;
        }
        [HttpPost]
        public IHttpActionResult CreateTeammember(Players player)
        {
            if(!ModelState.IsValid)
            {
                BadRequest();
            }
            _playerctx.Players.Add(player);
            _playerctx.SaveChanges();
            return Created(new Uri(Request.RequestUri+"/"+player.PlayersID),player);
        }
        public void ModifyTeammember(int id,Players player)
        {
            if (!ModelState.IsValid)
            {
              throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var playerInDb = _playerctx.Players.SingleOrDefault(p => p.PlayersID == id);
            if(playerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            playerInDb.Name = player.Name;
            _playerctx.SaveChanges();
        }

    }
}

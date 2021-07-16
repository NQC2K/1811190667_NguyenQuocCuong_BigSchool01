using _1811190667_NguyenQuocCuong_BigSchool01.DTOs;
using _1811190667_NguyenQuocCuong_BigSchool01.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1811190667_NguyenQuocCuong_BigSchool01.Controllers
{
    public class FollowingsController : ApiController
    {
        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Follow(FollowingDto followingDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
                return BadRequest("Following already exisits");
            var folowing = new Following
            {
                FollowerId = userId,
                FolloweeId = followingDto.FolloweeId
            };
            _dbContext.Followings.Add(folowing);
            _dbContext.SaveChanges();
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult DeleteFollowing(string id)
        {
            var userId = User.Identity.GetUserId();
            var follow = _dbContext.Followings.SingleOrDefault(a => a.FollowerId == userId && a.FolloweeId == id);
            if (follow == null)
                return NotFound();
            _dbContext.Followings.Remove(follow);
            _dbContext.SaveChanges();
            return Ok(id);
        }
    }
}

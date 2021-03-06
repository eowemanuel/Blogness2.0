﻿using System;
using System.Collections.Generic;
using System.Web.Http;
using Blog.Backend.Common.Contracts;
using Blog.Backend.Services.Implementation;

namespace Blog.Backend.Api.Rest.Controllers
{
    public class PostContentController : ApiController
    {
        private readonly IPostContents _postContentsSvc;

        public PostContentController(IPostContents postContentsSvc)
        {
            _postContentsSvc = postContentsSvc;
        }

        [HttpGet]
        [Route("api/posts/{postId:int}/contents")]
        public List<PostContent> GetList(int postId)
        {
            var postContents = new List<PostContent>();
            try
            {
                postContents = _postContentsSvc.GetByPostId(postId) ?? new List<PostContent>();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return postContents;
        }

        [HttpGet]
        [Route("api/postcontent/{postContentId:int}")]
        public PostContent Get(int postContentId)
        {
            try
            {
                return _postContentsSvc.Get(postContentId) ?? new PostContent();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        [HttpPost]
        [Route("api/postcontent")]
        public bool Post([FromBody]PostContent postContent)
        {
            try
            {
                _postContentsSvc.Add(postContent);
                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpDelete]
        [Route("api/postcontent")]
        public bool Delete([FromBody]int postContentId)
        {
            try
            {
                _postContentsSvc.Delete(postContentId);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

﻿using System.Collections.Generic;
using Blog.Backend.Common.Contracts;
using Blog.Backend.Logic.Factory;

namespace Blog.Backend.Services.Implementation
{
    public class PostContentsService : IPostContents
    {
        public List<PostContent> GetByPostId(int postId)
        {
            return PostContentsFactory.GetInstance().CreatePostContents().GetByPostId(postId);
        }

        public PostContent Get(int postContentId)
        {
            return PostContentsFactory.GetInstance().CreatePostContents().Get(postContentId);
        }

        public bool Add(PostContent postImage)
        {
            return PostContentsFactory.GetInstance().CreatePostContents().Add(postImage);
        }

        public bool Delete(int postContentId)
        {
            return PostContentsFactory.GetInstance().CreatePostContents().Delete(postContentId);
        }
    }
}

﻿using Blog.Backend.DataAccess.Repository;

namespace Blog.Backend.Logic.Factory
{
    public class PostContentsFactory
    {
        private PostContentsFactory()
        {
        }

        private static PostContentsFactory _instance;

        public static PostContentsFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new PostContentsFactory();
                return _instance;
            }
            return _instance;
        }

        public PostContentsLogic CreatePostContents()
        {
            IPostContentRepository postContentRepository = new PostContentRepository();
            return new PostContentsLogic(postContentRepository);
        }
    }
}

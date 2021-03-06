﻿using Blog.Backend.Common.Contracts;

namespace Blog.Backend.Logic.Mapper
{
    public static class PostContentMapper
    {
        public static PostContent ToDto(DataAccess.Entities.Objects.PostContent postContent)
        {
            return postContent == null ?
                new PostContent() :
                new PostContent
                {
                    PostContentId = postContent.PostContentId,
                    PostId = postContent.PostId,
                    Media = postContent.Media != null ? MediaMapper.ToDto(postContent.Media) : new Media(),
                    CreatedBy = postContent.CreatedBy,
                    CreatedDate = postContent.CreatedDate,
                    ModifiedBy = postContent.ModifiedBy,
                    ModifiedDate = postContent.ModifiedDate
                };
        }

        public static DataAccess.Entities.Objects.PostContent ToEntity(PostContent postContent)
        {
            return postContent == null ?
                new DataAccess.Entities.Objects.PostContent() :
                new DataAccess.Entities.Objects.PostContent
                {
                    PostContentId = postContent.PostContentId,
                    PostId = postContent.PostId,
                    Media = postContent.Media != null ? MediaMapper.ToEntity(postContent.Media) : new DataAccess.Entities.Objects.Media(),
                    MediaId = postContent.Media != null ? postContent.Media.MediaId : 0,
                    CreatedBy = postContent.CreatedBy,
                    CreatedDate = postContent.CreatedDate,
                    ModifiedBy = postContent.ModifiedBy,
                    ModifiedDate = postContent.ModifiedDate
                };
        }
    }
}

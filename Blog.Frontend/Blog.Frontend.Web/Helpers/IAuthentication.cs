﻿using Blog.Backend.Common.Contracts;

namespace Blog.Frontend.Web.Helpers
{
    public interface IAuthentication
    {
        bool SignIn(User user);
    }
}

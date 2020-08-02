// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityModel;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using IdentityServer4;

namespace IdentityServerHost.Quickstart.UI
{
    public class TestUsers
    {
        public static List<TestUser> Users
        {
            get
            {
                var address = new
                {
                    street_address = "One Hacker Way",
                    locality = "Heidelberg",
                    postal_code = 69118,
                    country = "Germany"
                };
                
                return new List<TestUser>
                {
                    new TestUser
                    {
                        SubjectId = "A75E0E18-9FDC-414E-8C18-5790490172F4",
                        Username = "Frank",
                        Password = "password",
                        Claims =
                        {
                            new Claim("given_name", "Frank"),
                            new Claim("family_name", "Underwoord"),
                        }
                    },
                    new TestUser
                    {
                        SubjectId = "9BCBDDF7-753C-4476-BB4D-B4F9C4300504",
                        Username = "Claire",
                        Password = "password",
                        Claims =
                        {
                            new Claim("given_name", "Claire"),
                            new Claim("family_name", "Underwoord"),
                        }
                    },
                };
            }
        }
    }
}
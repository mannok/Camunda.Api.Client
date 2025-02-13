﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Camunda.Api.Client.Identity
{
    public class IdentityVerifiedUser
    {
        /// <summary>
        /// The id of the user
        /// </summary>
        public string AuthenticatedUser { get; set; }
        /// <summary>
        /// Verification successful or not
        /// </summary>
        public bool Authenticated { get; set; }

    }
}

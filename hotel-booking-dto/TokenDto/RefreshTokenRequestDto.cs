﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel_booking_dto.TokenDto
{
    public class RefreshTokenRequestDto
    {
        public string UserId { get; set; }
        public Guid RefreshToken { get; set; }
    }
}

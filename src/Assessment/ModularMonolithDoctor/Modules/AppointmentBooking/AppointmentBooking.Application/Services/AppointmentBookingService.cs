﻿using AppointmentBooking.Application.ServicesAbstraction;
using AppointmentBooking.Domain.Models;
using AppointmentBooking.Domain.RepoAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBooking.Application.Services
{
    public class AppointmentBookingService : IAppointmentBookingService
    {
        private readonly IBookingRepo _bookingRepo;

        public AppointmentBookingService(IBookingRepo bookingRepo)
        {
            _bookingRepo = bookingRepo;
        }

        public List<BookingModel> MyBooking()
        {
            return _bookingRepo.GetBooking();
        }
    }
}

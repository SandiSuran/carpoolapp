using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using carpoolapp.BLL.Interfaces;
using carpoolapp.BLL.Resources;
using carpoolapp.BLL.Services.Communication;
using carpoolapp.Models;
using Microsoft.EntityFrameworkCore;

namespace carpoolapp.BLL.Services {

    public class EmployeeService : IEmployeeService {
        private readonly Context _db;
        private readonly IMapper _mapper;
        public EmployeeService (Context db, IMapper mapper) {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<EmployeeResource>> ListAsync()
        {
            var modelList = await _db.Employees.ToListAsync ();
            return _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeResource>> (modelList);
        }

        public async Task<TravelEmployeesResponse> ToggleTravelEmployees (IEnumerable<int> employeeIds, int travelId) {
            try {
                var existing = _db.TravelEmployees.Where (te => te.TravelId == travelId);
                var toAdd = employeeIds.Where (id => !existing.Any (e => e.EmployeeId == id))
                    .Select (id => new TravelEmployees { TravelId = travelId, EmployeeId = id })
                    .ToList ();

                var toRemove = existing.Where (e => !employeeIds.Any (id => e.EmployeeId == id)).ToList ();
                _db.RemoveRange (toRemove);

                await _db.AddRangeAsync (toAdd);
                await _db.SaveChangesAsync ();

                return new TravelEmployeesResponse ();

            } catch (Exception ex) {
                return new TravelEmployeesResponse ($"An error occurred when toggling the TravelEmployees: {ex.Message}");
            }

        }
    }
}
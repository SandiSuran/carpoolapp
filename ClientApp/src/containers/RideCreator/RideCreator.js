import React, { Component } from "react";
import axios from "axios";
import Auxillary from "../../hoc/Auxillary/Auxillary";
import DatePicker from "react-datepicker";
import Select from "react-select";

import classes from "./RideCreator.module.css";
import "react-datepicker/dist/react-datepicker.css";

class RideCreator extends Component {
  state = {
    cars: [],
    employees: [],
    multiOptions: [],
    selectedCar: {
      name: "",
      licensePlate: ""
    },
    selectedEmployees: [],
    startLocation: "",
    endLocation: "",
    startDate: new Date(),
    endDate: new Date(),
    isValidRide: true,
    loading: true
  };

  componentDidMount() {
    const requestCars = axios.get("car");
    const requestEmployees = axios.get("employee");
    axios
      .all([requestCars, requestEmployees])
      .then(
        axios.spread((...responses) => {
          const multiOptions = responses[1].data.map(emp => {
            return { value: emp.id, label: emp.fullName };
          });
          this.setState({
            cars: responses[0].data,
            employees: responses[1].data,
            multiOptions: multiOptions,
            loading: false
          });
        })
      )
      .catch(errors => {
        console.error(errors);
      });
  }
  postDataHandler = () => {
    let selectedEmpIds = [];
    this.state.selectedEmployees.forEach(empl => {
      selectedEmpIds.push(empl.value);
    });
    const data = {
      startLocation: this.state.startLocation,
      endLocation: this.state.endLocation,
      startDate: this.state.startDate,
      endDate: this.state.endDate,
      carLicensePlate: this.state.selectedCar.licensePlate,
      employeeIdList: selectedEmpIds
    };
    axios.post("travel", data).then(response => {
      console.log(response);
    });
  };

  startLocationChangeHandler = event => {
    this.setState({ startLocation: event.target.value });
  };
  endLocationChangeHandler = event => {
    this.setState({ endLocation: event.target.value });
  };
  startDateChangeHandler = date => {
    this.setState({ startDate: date });
  };
  endDateChangeHandler = date => {
    this.setState({ endDate: date });
  };
  handleMultiSelectChange = selectedOption => {
    this.setState({ selectedEmployees: selectedOption });
  };

  render() {
    const {
      startLocation,
      endLocation,
      startDate,
      endDate,
      selectedEmployees,
      multiOptions
    } = this.state;

    return (
      <Auxillary>
        <div className={classes.NewRide}>
          <h1>New Ride</h1>
          <label>Start Location</label>
          <input
            type="text"
            value={startLocation}
            onChange={this.startLocationChangeHandler}
          />
          <label>End Location</label>
          <input
            type="text"
            value={endLocation}
            onChange={this.endLocationChangeHandler}
          />
          <label>Start Date</label>
          <DatePicker
            selected={startDate}
            onChange={this.startDateChangeHandler}
          />
          <label>End Date</label>
          <DatePicker selected={endDate} onChange={this.endDateChangeHandler} />
          <label>Choose Employees for Ride</label>
          <Select
            value={selectedEmployees}
            onChange={this.handleMultiSelectChange}
            closeMenuOnSelect={false}
            options={multiOptions}
            isMulti
          />
          <label>Car</label>
          <select
            value={this.state.selectedCar.licensePlate}
            onChange={event =>
              this.setState({
                selectedCar: {
                  name: event.target.selectedOptions[0].text,
                  licensePlate: event.target.value
                }
              })
            }
          >
            {this.state.cars.map(car => {
              return (
                <option key={car.licensePlate} value={car.licensePlate}>
                  {car.name}
                </option>
              );
            })}
          </select>
          <button onClick={this.postDataHandler}>Create a carpool ride</button>
        </div>
      </Auxillary>
    );
  }
}

export default RideCreator;

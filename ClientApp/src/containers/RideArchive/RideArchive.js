import React, { Component } from 'react';
import Auxillary from '../../hoc/Auxillary/Auxillary';

class RideArchive extends Component {
    state = {
        travels: [], 
        loading: true
    }

    componentDidMount() {
        this.populateTravelData();
    }

    static renderTravelsTable(travels) {
        return (
          <table className='table table-striped' aria-labelledby="tableLabel">
            <thead>
              <tr>
                <th>Car License Plate</th>
                <th>Start Location</th>
                <th>End Location</th>
                <th>Ride Starts</th>
                <th>Ride Ends</th>
                <th>Number of passengers</th>
            </tr>
            </thead>
            <tbody>
              {travels.map(travel =>
                <tr key={travel.Id}>
                  <td>{travel.carLicensePlate}</td>
                  <td>{travel.startLocation}</td>
                  <td>{travel.endLocation}</td>
                  <td>{travel.startDate}</td>
                  <td>{travel.endDate}</td>
                  <td>4</td>
                </tr>
              )}
            </tbody>
          </table>
        );
      }
      
    render(){
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : RideArchive.renderTravelsTable(this.state.travels);
        return(
            <Auxillary>
                <h1 id="tableLabel" >Carpool Travels</h1>
                {contents}
            </Auxillary>
        );
        
    }

    async populateTravelData() {
        const response = await fetch('travel');
        const data = await response.json();
        this.setState({ travels: data, loading: false });
      }
}

export default RideArchive;
import React, { Component } from 'react';

export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { travels: [], loading: true };
  }

  componentDidMount() {
    this.populateTravelData();
  }

  static renderTravelsTable(travels) {
    return (
      <table className='table table-striped' aria-labelledby="tableLabel">
        <thead>
          <tr>
            <th>Date</th>
            <th>Temp. (C)</th>
            <th>Temp. (F)</th>
            <th>Summary</th>
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
            </tr>
          )}
        </tbody>
      </table>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderTravelsTable(this.state.travels);

    return (
      <div>
        <h1 id="tableLabel" >Carpool Travels</h1>
        {contents}
      </div>
    );
  }

  async populateTravelData() {
    const response = await fetch('travel');
    const data = await response.json();
    this.setState({ travels: data, loading: false });
  }
}

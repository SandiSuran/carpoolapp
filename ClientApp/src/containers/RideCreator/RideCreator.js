import React, { Component } from 'react';
import Aux from '../../hoc/Aux/Aux';

class RideCreator extends Component {
    state = {
        cars: [],
        employees:[], 
        loading: true
    }

    componentDidMount() {
        this.populateCarData();
        this.populateEmployeeData();
    }

    static renderRideCreator() {
        return (
            <h1 id="tableLabel" >New Travels</h1>
        )
    }
       

    render(){
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : RideCreator.renderRideCreator();
        return(
            <Aux>
                   {contents}       
            </Aux>
        );
        
    }

    async populateCarData() {
        const response = await fetch('car');
        const data = await response.json();
        this.setState({ cars: data, loading: false });
    }

    async populateEmployeeData() {
        const response = await fetch('employee');
        const data = await response.json();
        this.setState({ employees: data, loading: false });
    }
}

export default RideCreator;
import React, { Component } from 'react';
import { Route, Switch } from 'react-router-dom';

import Layout from './hoc/Layout/Layout';
import RideCreator from './containers/RideCreator/RideCreator'
import RideArchive from './containers/RideArchive/RideArchive'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <div>
        <Layout>
          <Switch>
            <Route path="/Travel" component={RideArchive} />
            <Route path="/" exact component={RideCreator} />
          </Switch>
        </Layout>
      </div>
    );
  }
}

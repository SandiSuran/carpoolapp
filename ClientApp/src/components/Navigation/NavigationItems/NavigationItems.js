import React from 'react';

import classes from './NavigationItems.module.css';
import NavigationItem from './NavigationItem/NavigationItem';

const navigationItems = () => (
    <ul className={classes.NavigationItems}>
        <NavigationItem link="/" exact active>New Ride</NavigationItem>
        <NavigationItem link="/Travel">Rides Archive</NavigationItem>
    </ul>
);

export default navigationItems;
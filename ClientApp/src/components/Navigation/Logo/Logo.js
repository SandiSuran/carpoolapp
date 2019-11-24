import React from 'react';

import carpoolLogo from '../../../assets/images/infobipCarpool.png';
import classes from './Logo.module.css';

const logo = (props) => (
    <div className={classes.Logo} style={{height: props.height}}>
        <img src={carpoolLogo} alt="InfobipCarpool" />
    </div>
);

export default logo;
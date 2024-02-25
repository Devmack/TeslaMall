import * as React from 'react';
import { styled } from '@mui/material/styles';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Unstable_Grid2';
import Button from '@mui/material/Button';
import Box from '@mui/material/Box';
import { Outlet, Link } from "react-router-dom";


const Item = styled(Paper)(({ theme }) => ({
    backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
    ...theme.typography.body2,
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
}));

function LandingPage() {
  
  return (

      <Grid container spacing={2}>
          <Grid xs={12} textAlign="center">
              <h2>Welcome to the TeslaMall!</h2>
              <h5>Where people enjoy their travel</h5>
              
              

          </Grid>
          <Grid xl={4}>
              <Box><Paper elevation={3}> Test! </Paper></Box>
              
          </Grid>
          <Grid xl={4}>
              <Box><Paper elevation={3}> Test! </Paper></Box>

          </Grid>
          <Grid xl={4}>
              <Box><Paper elevation={3}> Test! </Paper></Box>

          </Grid>
          <Grid xs={12} xl={12} textAlign="center">
              <Button variant="outlined" ><Link to={`/RentLocations`}>Location</Link></Button>
              <Button variant="outlined">Cars</Button>
              <Button variant="outlined">See my reservations</Button>
          </Grid>
          <Grid xs={6}>
          </Grid>
      </Grid>
  );
}

export default LandingPage;
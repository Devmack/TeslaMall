import * as React from 'react';
import { styled } from '@mui/material/styles';
import Paper from '@mui/material/Paper';
import Grid from '@mui/material/Grid';
import Button from '@mui/material/Button';
import Box from '@mui/material/Box';
import { Outlet, Link } from "react-router-dom";
import { Typography } from "@mui/material";
import backgroundImage from '../../public/mallorca_placeholder_image.jpg';

const Item = styled(Paper)(({ theme }) => ({
    backgroundColor: theme.palette.mode === 'dark' ? '#1A2027' : '#fff',
    ...theme.typography.body2,
    padding: theme.spacing(1),
    textAlign: 'center',
    color: theme.palette.text.secondary,
}));

const Container = styled(Box)({
    height: '100vh',
    display: 'flex',
    justifyContent: 'center',
    alignItems: 'center',
    backgroundImage: `url(${backgroundImage})`,
    backgroundSize: 'cover',
    backdropFilter: 'blur(5px)',
});

const GridContent = styled(Grid)({
    backgroundColor: 'rgba(255, 255, 255, 0.5)',
    padding: '20px',
    borderRadius: '8px',
    boxShadow: '0 0 10px rgba(0, 0, 0, 0.2)',
});

const Footer = styled('footer')({
    position: 'sticky',
    bottom: 0,
    backgroundColor: 'rgba(255, 255, 255, 0.8)',
    padding: '10px',
    textAlign: 'center',
});

function LandingPage() {

    return (
        <>
            <Container>
                <GridContent>
                    <Grid container spacing={2} direction="column" justifyContent="center" alignItems="center">
                        <Grid item xs={12} textAlign="center">
                            <h2>Welcome to the TeslaMall!</h2>
                            <h5>Where people enjoy their travel</h5>
                            <p>Discover the beautiful island of Mallorca with TeslaMall. Rent your dream car and explore!</p>
                        </Grid>
                        <Grid item xs={12} textAlign="center">
                            <Button variant="outlined" ><Link to={`/RentLocations`}>Location</Link></Button>
                            <Button variant="outlined"><Link to={`/ManageRent`}>See my reservations</Link></Button>
                        </Grid>
                    </Grid>
                </GridContent>
            </Container>
            <Footer>
                <Typography variant="body2" color="textSecondary">
                    Created by Dominik Starzyk | Email: starzykdominik93@gmail.com | LinkedIn: <Link href="http://www.linkedin.com/in/dominik-starzyk-002874129">Dominik Starzyk</Link>
                </Typography>
            </Footer>
        </>
    );
}

export default LandingPage;

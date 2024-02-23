import React, { useState, useEffect } from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import CardActions from '@mui/material/CardActions';
import Typography from '@mui/material/Typography';
import Button from '@mui/material/Button';
import Chip from '@mui/material/Chip';
import CarRentalIcon from '@mui/icons-material/CarRental';
import { CardActionArea } from '@mui/material';
import { Outlet, Link } from "react-router-dom";

export default function LocationTile({ Location }) {

    const title = Location.locationName;
    const [availableCars, setAvailableCars] = useState([]);

    useEffect(() => {
        setAvailableCars(Location.carsAtLocation.filter((car) => car.relatedReservationId == null));
    }, []);


    return (
        <Card sx={{ maxWidth: 345 }}>
            <CardActionArea>
                <CardMedia
                    component="img"
                    height="140"
                    image="/mallorca_placeholder_image.jpg"
                    alt="green iguana"
                />
                <CardContent>
                    <Typography gutterBottom variant="h5" component="div">
                        {Location.locationName}
                    </Typography>
                    <Typography variant="body2" color="text.secondary">
                        {Location.locationDescription}
                    </Typography>
                    <Chip icon={<CarRentalIcon />} label={"available cars " + availableCars.length} color="primary" />
                </CardContent>
                <CardActions>
                    <Button size="small"><Link
                        to="/Reservation" state={{location: Location}}>Reserve</Link></Button>
                </CardActions>
            </CardActionArea>
        </Card>
    );
}
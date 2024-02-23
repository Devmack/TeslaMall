import React, { useState, useEffect } from 'react';
import Card from '@mui/material/Card';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Typography from '@mui/material/Typography';
import { CardActionArea } from '@mui/material';

export default function LocationTile({ Location }) {

    const title = Location.locationName;

    useEffect(() => {
        console.log(Location);
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
                </CardContent>
            </CardActionArea>
        </Card>
    );
}
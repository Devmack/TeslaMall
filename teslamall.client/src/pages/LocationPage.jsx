import React, { useState, useEffect } from 'react';
import { GetAllLocations } from '../services/LocationApi';
import LocationTile from '../components/LocationTile';
import Grid from '@mui/material/Grid';

function LocationPage() {
    const [data, setData] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);


    useEffect(() => {
        const fetchData = async () => {
            try {
                const locations = await GetAllLocations();
                setData(locations);
                setLoading(false);
            } catch (error) {
                setError(error);
                setLoading(false);
            }
        };
        fetchData();
    }, []);

    if (loading) return <div>Loading...</div>;
    if (error) return <div>Error</div>;

    return (
        <div>
            <Grid container spacing={2} justifyContent="center" 
                alignItems="center" 
                style={{ minHeight: '100vh' }} >
            {data && (
                    data.map(item => (
                        <Grid>
                            <LocationTile key={item.id} Location={item} />
                        </Grid>
                ))
                )}
            </Grid>
        </div>
    );
}

export default LocationPage;
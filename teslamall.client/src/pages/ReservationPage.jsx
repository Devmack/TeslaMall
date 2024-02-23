import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import MenuItem from '@mui/material/MenuItem';
import { FormControl, InputLabel, Select, Button, Grid } from '@mui/material';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css'; 

function ReservationPage(props) {
    let { state } = useLocation([]);

    const cars = [
        { id: 1, name: 'Car A' },
        { id: 2, name: 'Car B' },
        { id: 3, name: 'Car C' },
    ];

    useEffect(() => {
        console.log(state);
    }, []);

    const [startDate, setStartDate] = useState(null);
    const [endDate, setEndDate] = useState(null);
    const [selectedCar, setSelectedCar] = useState('');

    const handleStartDateChange = (date) => {
        setStartDate(date);
    };

    const handleEndDateChange = (date) => {
        setEndDate(date);
    };

    const handleCarChange = (event) => {
        setSelectedCar(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        console.log('Start Date:', startDate);
        console.log('End Date:', endDate);
        console.log('Selected Car:', selectedCar);
    };

    return (
        <div>
            {state ? (
                <>
                    <h2>Reserve car at {state.location.locationName}! </h2>
                    <p>You are one step closer to your dream journey!</p>
                    <form onSubmit={handleSubmit}>
                        <Grid container spacing={2}>
                            <Grid item xs={12} sm={6}>
                                <DatePicker
                                    selected={startDate}
                                    onChange={handleStartDateChange}
                                    dateFormat="yyyy-MM-dd"
                                    className="form-control" 
                                    placeholderText="Start Date"
                                />
                            </Grid>
                            <Grid item xs={12} sm={6}>
                                <DatePicker
                                    selected={endDate}
                                    onChange={handleEndDateChange}
                                    dateFormat="yyyy-MM-dd"
                                    className="form-control" 
                                    placeholderText="End Date"
                                />
                            </Grid>
                            <Grid item xs={12}>
                                <FormControl>
                                    <InputLabel id="car-label">Select Car</InputLabel>
                                    <Select
                                        labelId="car-label"
                                        value={selectedCar}
                                        onChange={handleCarChange}
                                    >
                                        {cars.map((car) => (
                                            <MenuItem key={car.id} value={car.id}>
                                                {car.name}
                                            </MenuItem>
                                        ))}
                                    </Select>
                                </FormControl>
                            </Grid>
                            <Grid item xs={12}>
                                <Button variant="contained" color="primary" type="submit">
                                    Submit
                                </Button>
                            </Grid>
                        </Grid>
                    </form>
                </>
            ) : (
                <p>No location data available</p>
            )}
        </div>
    );
}

export default ReservationPage;

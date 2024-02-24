import React, { useState, useEffect } from 'react';
import { useLocation } from 'react-router-dom';
import MenuItem from '@mui/material/MenuItem';
import { FormControl, InputLabel, Select, Button, Grid, TextField, Divider } from '@mui/material';
import DatePicker from 'react-datepicker';
import 'react-datepicker/dist/react-datepicker.css';
import RentalSummaryModal from '../components/RentalSummaryModal';

function ReservationPage(props) {
    let { state } = useLocation([]);

    let cars = state.location.carsAtLocation

    useEffect(() => {
        cars = state.location.carsAtLocation
    }, []);

    const [startDate, setStartDate] = useState(null);
    const [endDate, setEndDate] = useState(null);
    const [selectedCar, setSelectedCar] = useState('');
    const [email, setEmail] = useState('');
    const [showElement, setShowElement] = useState(false);
    const [summaryModal, setsummaryModal] = useState(false);
    const [reservationDuration, setReservationDuration] = useState(0);

    const handleStartDateChange = (date) => {
        setStartDate(date);
        if (date && startDate) {
            setReservationDuration(calculateDaysDifference(date, endDate))
            setShowElement(true);
        }
    };

    const handleEndDateChange = (date) => {
        setEndDate(date);
        if (date && endDate) {
            setReservationDuration(calculateDaysDifference(startDate, date))
            setShowElement(true);
        }
    };

    const handleCalendarClose = (date) => {
        if (startDate && endDate) {
            setReservationDuration(calculateDaysDifference(startDate, endDate))
            setShowElement(true);
        }
    }

    function calculateDaysDifference(start, end) {
        const startDateTime = start.getTime();
        const endDateTime = end.getTime();
        const timeDifference = endDateTime - startDateTime;
        const daysDifference = Math.ceil(timeDifference / (1000 * 3600 * 24));
        return daysDifference;
    }

    const handleCarChange = (event) => {
        setSelectedCar(event.target.value);
    };

    const handleEmailChange = (event) => {
        setEmail(event.target.value);
    };

    const handleSubmit = (event) => {
        event.preventDefault();
        console.log('Start Date:', startDate);
        console.log('End Date:', endDate);
        console.log('Selected Car:', selectedCar);
        console.log('Selected email:', email);
        setsummaryModal(true);
    };

    return (
        <>
        <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', minHeight: '100vh' }}>
            <div style={{ textAlign: 'center' }}>
                {state ? (
                    <>
                        <form onSubmit={handleSubmit}>
                            <Grid container spacing={1} direction="column" alignItems="center">
                                <Grid item xl="6">
                                    <h2>Reserve car at {state.location.locationName}! </h2>
                                    <p>You are one step closer to your dream journey!</p>
                                </Grid>
                                <Grid item>
                                    <DatePicker
                                        selected={startDate}
                                        onChange={handleStartDateChange}
                                        dateFormat="yyyy-MM-dd"
                                        className="form-control"
                                        placeholderText="Start Date"
                                        onCalendarClose={handleCalendarClose}
                                    />
                                    <DatePicker
                                        selected={endDate}
                                        onChange={handleEndDateChange}
                                        dateFormat="yyyy-MM-dd"
                                        className="form-control"
                                        placeholderText="End Date"
                                        onCalendarClose={handleCalendarClose}
                                    />
                                </Grid>
                                <Divider variant="middle" style={{ margin: '20px 0' }} />
                                <Grid item>
                                    <FormControl>
                                        <InputLabel id="car-label">Select Car</InputLabel>
                                        <Select
                                            labelId="car-label"
                                            value={selectedCar}
                                            onChange={handleCarChange}
                                        >
                                            {cars.map((car) => (
                                                <MenuItem key={car.id} value={car.id}>
                                                    {car.modelName}
                                                </MenuItem>
                                            ))}
                                        </Select>
                                    </FormControl>
                                </Grid>
                                <Grid item>
                                    <TextField
                                        label="Email"
                                        variant="outlined"
                                        value={email}
                                        onChange={handleEmailChange}
                                    />
                                </Grid>
                                <Grid item>
                                    <Button variant="contained" color="primary" type="submit">
                                        Submit
                                    </Button>
                                </Grid>
                            </Grid>
                        </form>
                        <Grid container direction="column">
                            {showElement && (
                                <Grid item>
                                    <p>You will spend {reservationDuration} days at location!</p>
                                </Grid>
                            )}
                        </Grid>
                    </>
                ) : (
                    <p>No location data available</p>
                )}
            </div>
            </div>
            <RentalSummaryModal isOpen={summaryModal} onClose={() => setsummaryModal(false)}
                carName={selectedCar} rentalDuration={reservationDuration} email={email}
                end={endDate} start={startDate}
            ></RentalSummaryModal>
        </>
    );
}

export default ReservationPage;

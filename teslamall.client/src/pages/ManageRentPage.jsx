import React, { useState } from 'react';
import { Card, CardContent, Typography, TextField, Button, FormControl, InputLabel, Select, MenuItem, Modal, Box } from '@mui/material';
import { CancelReservation, GetReservationDetails } from '../services/RentalAPI';
import { useNavigate } from "react-router-dom";
import { GetAllLocations, ChangeCarLocation } from '../services/LocationApi';

function ManageRentPage() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [isAuthenticated, setIsAuthenticated] = useState(false);
    const [reservation, setReservation] = useState();
    const [showModal, setShowModal] = useState(false);
    const [returnLocation, setReturnLocation] = useState('');
    const [cancelConfirmed, setCancelConfirmed] = useState(false);
    const [locations, setLocations] = useState([]);
    const navigate = useNavigate();

    const handleLogin = async () => {
        try {
            const data = await GetReservationDetails({
                email: email, code: password
            });
            if (data !== undefined) {
                setIsAuthenticated(true);
                setReservation(data);
                console.log(reservation);
            }
        } catch (error) {
            alert('Invalid credentials');
        }
    };

    const handleCancelRent = async () => {
        setShowModal(true);
        try {
            const data = await GetAllLocations();
            if (data !== undefined) {
                setLocations(data);
            }
        } catch (error) {
            alert('Error while fetching possible return locations');
        }

    };

    const handleCloseModal = () => {
        setShowModal(false);
    };

    const handleSelectReturnLocation = (location) => {
        setReturnLocation(location);
    };

    const handleConfirmCancel = async () => {
        try {

            const data = await CancelReservation({
                email: email, code: password, returnLocation: returnLocation
            });

            const carMovedToNewLocation = await ChangeCarLocation({carId: reservation.rentedCarId, locationId: returnLocation })
            if (carMovedToNewLocation == true) {
                navigate('/');
            }
        } catch (error) {
            alert('Error cancelling reservation');
        }
    };

    return (
        <Card style={{ maxWidth: 400, margin: '0 auto' }}>
            <CardContent>
                {!isAuthenticated ? (
                    <div style={{ textAlign: 'center' }}>
                        <Typography variant="h5" gutterBottom>
                            Rental Authentication
                        </Typography>
                        <FormControl fullWidth style={{ marginBottom: '10px' }}>
                            <TextField
                                label="Email"
                                variant="outlined"
                                value={email}
                                onChange={(e) => setEmail(e.target.value)}
                            />
                        </FormControl>
                        <FormControl fullWidth style={{ marginBottom: '20px' }}>
                            <TextField
                                label="Password"
                                type="password"
                                variant="outlined"
                                value={password}
                                onChange={(e) => setPassword(e.target.value)}
                            />
                        </FormControl>
                        <Button variant="contained" color="primary" onClick={handleLogin}>
                            Login
                        </Button>
                    </div>
                ) : (
                    <>
                        <Typography variant="h5" gutterBottom>
                            Rent Details
                        </Typography>
                        <Typography variant="body1">
                            <strong>Email:</strong> {email}
                        </Typography>
                        <Typography variant="body1">
                            <strong>Rented car:</strong> {reservation.rentedCar.modelName}
                        </Typography>
                        <Typography variant="body1">
                            <strong>Paid:</strong> {reservation.reservationCosts} USD
                        </Typography>
                        <Typography variant="body1">
                            <strong>From: </strong> {reservation.reservationPeriod.reservationStart}
                        </Typography>
                        <Typography variant="body1">
                            <strong>To: </strong> {reservation.reservationPeriod.reservationEnd}
                        </Typography>
                        <Typography variant="body1">
                            <strong>In total: </strong> {reservation.reservationPeriod.reservationLength} days rent
                        </Typography>
                        <Button variant="contained" color="secondary" onClick={handleCancelRent} style={{ marginTop: '20px' }}>
                            Cancel Rent
                        </Button>
                    </>
                )}
            </CardContent>

            <Modal open={showModal} onClose={handleCloseModal}>
                <Box sx={{ position: 'absolute', top: '50%', left: '50%', transform: 'translate(-50%, -50%)', bgcolor: 'background.paper', boxShadow: 24, p: 4, width: 300 }}>
                    <Typography variant="h6" gutterBottom>
                        Select Return Location
                    </Typography>
                    <FormControl fullWidth>
                        <InputLabel id="return-location-label">Return Location</InputLabel>
                        <Select
                            labelId="return-location-label"
                            value={returnLocation}
                            onChange={(e) => handleSelectReturnLocation(e.target.value)}
                        >
                            {locations.map((location) => (
                                <MenuItem key={location.id} value={location.id}>
                                    {location.locationName}
                                </MenuItem>
                            ))}
                        </Select>
                    </FormControl>
                    <Button variant="contained" color="primary" onClick={handleConfirmCancel} disabled={!returnLocation} style={{ marginTop: '20px' }}>
                        Confirm Cancel
                    </Button>
                </Box>
            </Modal>
        </Card>
    );
}

export default ManageRentPage;

import React, { useState } from 'react';
import { Card, CardContent, Typography, TextField, Button } from '@mui/material';
import { CancelReservation, GetReservationDetails } from '../services/RentalAPI';

function ManageRentPage() {
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [isAuthenticated, setIsAuthenticated] = useState(false);
    const [reservation, setReservation] = useState();

    const handleLogin = async () => {
        try {
            const data = await GetReservationDetails({
                email: email, code: password
            });
            console.log(data)
            if (data != undefined) {
                setIsAuthenticated(true);
                setReservation(data);
                console.log(data);
            }
        } catch (error) {
            alert('Invalid credentials');
        }
    };

    const handleCancelRent = async () => {
        alert('Rent cancelled');
        try {
            const data = await CancelReservation({
                email: email, code: password
            });
            console.log(data)
        } catch (error) {
            alert('Invalid credentials');
        }
    };

    return (
        <>
            {!isAuthenticated ? (
                <div style={{ textAlign: 'center' }}>
                    <Typography variant="h5" gutterBottom>
                        Rental Authentication
                    </Typography>
                    <TextField
                        label="Email"
                        variant="outlined"
                        value={email}
                        onChange={(e) => setEmail(e.target.value)}
                        fullWidth
                        style={{ marginBottom: '10px' }}
                    />
                    <TextField
                        label="Password"
                        type="password"
                        variant="outlined"
                        value={password}
                        onChange={(e) => setPassword(e.target.value)}
                        fullWidth
                        style={{ marginBottom: '20px' }}
                    />
                    <Button variant="contained" color="primary" onClick={handleLogin}>
                        Login
                    </Button>
                </div>
            ) : (
                <Card style={{ maxWidth: 400, margin: '0 auto' }}>
                    <CardContent>
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
                    </CardContent>
                </Card>
            )}
        </>
    );
}

export default ManageRentPage;

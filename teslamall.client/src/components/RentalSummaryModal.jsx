import React, { useState } from 'react';
import { Modal, Box, Typography, Button, TextField, CircularProgress } from '@mui/material';
import { CreateReservation, ConfirmReservation } from '../services/RentalAPI';

function RentalSummaryModal({ isOpen, onClose, carName, rentalDuration, rentalCost, start, end, email }) {
    const [confirmCode, setConfirmCode] = useState('');
    const [isConfirmed, setIsConfirmed] = useState(false);
    const [cost, setCost] = useState('');
    const [isPaying, setIsPaying] = useState(false);
    const [paymentMessage, setPaymentMessage] = useState('');
    const [isPaymentSuccessful, setIsPaymentSuccessful] = useState(false);

    const handleConfirm = async () => {
        try {
            setIsConfirmed(true);
            const data = await CreateReservation({
                id: "93243b0e-6fbf-4a68-a6c1-6da4b4e3c3e4",
                rentedCarId: carName,
                reservationPeriod: { reservationStart: start, reservationEnd: end, reservationLength: rentalDuration, relatedReservationId: "93243b0e-6fbf-4a68-a6c1-6da4b4e3c3e4" }
            });
            console.log(data);
            setCost(data.reservationCosts);
        } catch (error) {
            console.error('Error confirming rental:', error);
        }
    };

    const handlePay = async () => {
        try {
            setIsPaying(true);
            const data = await ConfirmReservation({
                id: "93243b0e-6fbf-4a68-a6c1-6da4b4e3c3e1",
                email: email, reservationCode: 1234, reservationId: "93243b0e-6fbf-4a68-a6c1-6da4b4e3c3e4"
            });
            setIsPaying(false);
            setIsConfirmed(true);
            setIsPaymentSuccessful(true);
            setPaymentMessage('Payment was successful!');
        } catch (error) {
            console.error('Error confirming rental:', error);
            setIsPaying(false);
            setPaymentMessage('Payment failed. Please try again.');
        }
    };

    return (
        <Modal
            open={isOpen}
            onClose={onClose}
            aria-labelledby="modal-title"
            aria-describedby="modal-description"
        >
            <Box
                sx={{
                    position: 'absolute',
                    top: '50%',
                    left: '50%',
                    transform: 'translate(-50%, -50%)',
                    bgcolor: 'background.paper',
                    boxShadow: 24,
                    p: 4,
                    minWidth: 300,
                    maxWidth: 600,
                    textAlign: 'center'
                }}
            >
                <Typography id="modal-title" variant="h5" gutterBottom>
                    Rental Summary
                </Typography>
                <Typography id="modal-description" variant="body1" gutterBottom>
                    <strong>Email of customer:</strong> {email}
                </Typography>
                <Typography id="modal-description" variant="body1" gutterBottom>
                    <strong>Car Name:</strong> {carName}
                </Typography>
                <Typography id="modal-description" variant="body1" gutterBottom>
                    <strong>Rental Duration:</strong> {rentalDuration} days
                </Typography>

                {!isConfirmed ? (
                    <Button variant="contained" color="primary" onClick={handleConfirm} sx={{ mt: 2 }}>
                        Confirm
                    </Button>
                ) : (
                    <>
                        <Typography id="modal-description" variant="body1" gutterBottom>
                            <strong>Rental Cost:</strong> ${cost}
                        </Typography>
                        <TextField
                            label="Confirm Code"
                            variant="outlined"
                            value={confirmCode}
                            onChange={(e) => setConfirmCode(e.target.value)}
                            sx={{ mt: 2 }}
                        />
                        {isPaying ? (
                            <CircularProgress sx={{ mt: 2 }} />
                        ) : (
                            <>
                                {!isPaymentSuccessful ? (
                                    <Button
                                        variant="contained"
                                        color="primary"
                                        onClick={handlePay}
                                        disabled={!confirmCode}
                                        sx={{ mt: 2 }}
                                    >
                                        Pay
                                    </Button>
                                ) : (
                                    <Button
                                        variant="contained"
                                        color="primary"
                                        onClick={onClose}
                                        sx={{ mt: 2 }}
                                    >
                                        Return to Main Page
                                    </Button>
                                )}
                                {paymentMessage && <Typography variant="body1" sx={{ mt: 2 }}>{paymentMessage}</Typography>}
                            </>
                        )}
                    </>
                )}
                <Button variant="contained" color="secondary" onClick={onClose} sx={{ mt: 2, ml: 2 }}>
                    Reject
                </Button>
            </Box>
        </Modal>
    );
}

export default RentalSummaryModal;

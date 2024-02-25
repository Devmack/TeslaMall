import axios from 'axios';

const API_URL = 'https://localhost:7249';

export const CreateReservation = async (reservationData) => {
    try {
        const response = await axios.post(`${API_URL}/Reservation`, reservationData);
        return response.data;
    } catch (error) {
        throw error;
    }
};

export const ConfirmReservation = async (reservationData) => {
    try {
        const response = await axios.post(`${API_URL}/Confirmation`, reservationData);
        return response.data;
    } catch (error) {
        throw error;
    }
};

export const GetReservationDetails = async (reservationData) => {
    try {
        const response = await axios.post(`${API_URL}/UserReservation`, reservationData);
        return response.data;
    } catch (error) {
        throw error;
    }
};

export const CancelReservation = async (reservationData) => {
    try {
        const response = await axios.post(`${API_URL}/CancelReservation`, reservationData);
        return response.data;
    } catch (error) {
        throw error;
    }
};

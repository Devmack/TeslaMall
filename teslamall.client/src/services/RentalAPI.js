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

export const RemoveReservation = async (id) => {
    try {
        const response = await axios.delete(`${API_URL}/Remove/Reservation?id=${id}`);
        return response.data;
    } catch (error) {
        throw error;
    }
};

export const RentExists = async (email) => {
    try {
        const response = await axios.get(`${API_URL}/Rent/${email}/exists`);
        return response.data;
    } catch (error) {
        throw error;
    }
};

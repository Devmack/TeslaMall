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
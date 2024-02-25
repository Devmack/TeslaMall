import axios from 'axios';

const API_URL = 'https://localhost:7249';

export const GetAllLocations = async () => {
    try {
        const response = await axios.get(`${API_URL}/Locations`);
        return response.data;
    } catch (error) {
        throw error;
    }
};

export const GetCarsAtLocation = async (locationName) => {
    try {
        const response = await axios.get(`${API_URL}/Locations/${locationName}/Cars`);
        return response.data;
    } catch (error) {
        throw error;
    }
};
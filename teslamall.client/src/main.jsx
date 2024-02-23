import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './App.jsx'
import {
    createBrowserRouter,
    RouterProvider,
} from "react-router-dom";
import './index.css'
import LocationPage from './pages/LocationPage.jsx';
import ReservationPage from './pages/ReservationPage.jsx';

const router = createBrowserRouter([
    {
        path: "/",
        element: <App></App>,
    },
    {
        path: "/RentLocations",
        element: <LocationPage></LocationPage>,
    },
    {
        path: "/Reservation",
        element: <ReservationPage></ReservationPage>,
    },
]);


ReactDOM.createRoot(document.getElementById("root")).render(
    <React.StrictMode>
        <RouterProvider router={router} />
    </React.StrictMode>
);

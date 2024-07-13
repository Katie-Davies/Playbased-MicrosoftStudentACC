import React from 'react'
import ReactDOM from 'react-dom/client'
import App from './pages/App.tsx'
import { QueryClient, QueryClientProvider } from '@tanstack/react-query'
import { RouterProvider, createBrowserRouter } from 'react-router-dom'
import routes from './routes.tsx'

const router = createBrowserRouter(routes)

const queryClient = new QueryClient()

ReactDOM.createRoot(document.getElementById('root')!).render(
  <QueryClientProvider client={queryClient}>
    <React.StrictMode>
      <RouterProvider router={router} />
      {/* <App /> */}
    </React.StrictMode>
  </QueryClientProvider>
)

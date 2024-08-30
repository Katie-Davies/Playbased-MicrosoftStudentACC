import { useQuery } from '@tanstack/react-query'
import { getAllActivities } from '../apis/apiClient'

export function useGetAllActivities() {
  return useQuery({
    queryKey: ['activities'],
    queryFn: async () => await getAllActivities(),
  })
}

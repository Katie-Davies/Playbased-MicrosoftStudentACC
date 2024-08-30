import { useQuery } from '@tanstack/react-query'
import { getActivitiesByAgeGroup } from '../apis/apiClient'

export function useGetActivitiesByAge(selectedId: number) {
  return useQuery({
    queryKey: ['age', selectedId],
    queryFn: async () => await getActivitiesByAgeGroup(selectedId),
  })
}

import { useQuery } from '@tanstack/react-query'
import { getActivityByMaterial } from '../apis/apiClient'

export function useGetActivitiesByAge(selectedMaterial: string) {
  return useQuery({
    queryKey: ['material', selectedMaterial],
    queryFn: async () => await getActivityByMaterial(selectedMaterial),
  })
}

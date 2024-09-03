import { useQuery } from '@tanstack/react-query'
import { getActivityById } from '../apis/apiClient'

export default function useGetActivityById(id: number) {
  return useQuery({
    queryKey: ['activityId', id],
    queryFn: () => getActivityById(id),
  })
}
